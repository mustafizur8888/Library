using System.Collections.Generic;
using System.Linq;
using Library.Models.Catalog;
using LibraryData;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ILibraryAsset _asset;
        public CatalogController(ILibraryAsset asset)
        {
            _asset = asset;
        }

        [HttpGet(Name = "Get")]
        public IActionResult Get()
        {
            var assetModel = _asset.GetAll();
            var listingModel = assetModel.Select(
                result => new AssetIndexListingModel()
                {
                    Id = result.Id,
                    ImageUrl = result.ImageUrl,
                    Title = result.Title,
                    DeweyCallNumber = _asset.GetDeweyIndex(result.Id),
                    Type = _asset.GetType(result.Id),
                    AuthorOrDirector = _asset.GetAuthorOrDirector(result.Id)
                });
            var model = new AssetIndexModel()
            {
                Asset = listingModel
            };

            return Ok(model);
        }
    }
}
