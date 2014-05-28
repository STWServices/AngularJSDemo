using Controller;
using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStore
{
    /// <summary>
    /// Summary description for ImgHandler
    /// </summary>
    public class ImgHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            //context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            

            byte[] buffer = null;
            string querySqlStr = "";
            ProductController _ProductController = new ProductController();
            ProductModel _ProductModel = null;
            if (context.Request.QueryString["ImageID"] != null)
            {
                _ProductModel = _ProductController.GetProductImage("Img",Convert.ToInt32(context.Request.QueryString["ImageID"]));
              
                buffer = _ProductModel.ImageByte;
                context.Response.Clear();
                context.Response.ContentType = _ProductModel.ImageType;
                context.Response.BinaryWrite(buffer);
                context.Response.Flush();
                //context.Response.Close();
            }
           
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}