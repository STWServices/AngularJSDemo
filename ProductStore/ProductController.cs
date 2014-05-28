using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.SessionState;

using Controller;
using Shared;
using Shared.Models;

namespace ProductStore
{
    public class ProductController : ApiController
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        public List<ProductModel> GetProducts()
        {
            CommonController commonController = HttpContext.Current.Session["CommonController"] as CommonController;
            if (commonController == null)
                commonController = new CommonController();
            List<ProductModel> returnData = commonController.ExecuteOperation(OperationType.Read, null) as List<ProductModel>;

            return returnData;
        }

        /// <summary>
        /// Get product by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ProductModel> GetProductById(Int32 id)
        {
            CommonController commonController = HttpContext.Current.Session["CommonController"] as CommonController;
            if (commonController == null)
                commonController = new CommonController();
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("id", id);
            List<ProductModel> returnData = commonController.ExecuteOperation(OperationType.ReadById, data) as List<ProductModel>;

            return returnData;
        }

        /// <summary>
        /// Get all products of the required category.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<ProductModel> Post([FromBody] String category)
        {
            CommonController commonController = HttpContext.Current.Session["CommonController"] as CommonController;
            if (commonController == null)
                commonController = new CommonController();
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("category", category);
            List<ProductModel> returnData = commonController.ExecuteOperation(OperationType.ReadByCategory, data) as List<ProductModel>;

            return returnData;
        }

        public ProductModel GetProductImage(string type, Int32 id)
        {
            CommonController commonController11 = new CommonController(); //HttpContext.Current.Session["CommonController"] as CommonController;           
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("id", id);
            ProductModel returnData = commonController11.ExecuteOperation(OperationType.ReadImage, data) as ProductModel;

            return returnData;
        }
    }
}