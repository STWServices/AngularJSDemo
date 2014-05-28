using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    /// <summary>
    /// OperationType Class
    /// </summary>
    public static class OperationType
    {
        //add the mappings for operation type and its corresponding sql query text
        public static readonly Dictionary<String, String> Map
            = new Dictionary<String, String>
            {
                {Read, OperationText.Read},
                {ReadByCategory, OperationText.ReadByCategory},
                {ReadById, OperationText.ReadById},
                 {ReadImage, OperationText.ReadImage}
            };

        public const String Read = "Read";
        public const String ReadByCategory = "ReadByCategory";
        public const String ReadById = "ReadById";
        public const String ReadImage = "ReadImage";
    }

    /// <summary>
    /// Class to provide custom exception messages
    /// </summary>
    public static class Exceptions
    {
        public const String Error = "Some error has occured";
    }

    /// <summary>
    /// OperationText Class
    /// </summary>
    public static class OperationText
    {
        public const String Read = "select p.Id,p.Name,'' as AuthorName,'' as PublisherName,p.Price,0.10 as Discount,p.ApprovedRatingSum as Rating,'US' as [Language],p.CreatedOnUtc as PublicationYear ,'' as ISBN13,'' as ISBN10,c.Name as Category,'' as [Image],p.ShortDescription as Details,ppm.PictureId as ImageId,pp.PictureBinary as ImageByte   from Product p  inner join Product_Picture_Mapping ppm on ppm.productId=p.Id  inner join picture pp on pp.id=ppm.pictureId  inner join Product_Category_Mapping pcm on pcm.ProductId=p.Id  inner join Category c on c.Id=pcm.CategoryId";
        public const String ReadByCategory = "select p.Id,p.Name,'' as AuthorName,'' as PublisherName,p.Price,0.10 as Discount,p.ApprovedRatingSum as Rating,'US' as [Language],p.CreatedOnUtc as PublicationYear ,'' as ISBN13,'' as ISBN10,c.Name as Category,'' as [Image],p.ShortDescription as Details,ppm.PictureId as ImageId ,pp.PictureBinary as ImageByte  from Product p  inner join Product_Picture_Mapping ppm on ppm.productId=p.Id   inner join picture pp on pp.id=ppm.pictureId  inner join Product_Category_Mapping pcm on pcm.ProductId=p.Id  inner join Category c on c.Id=pcm.CategoryId WHERE c.Name = @category";
        public const String ReadById = "select p.Id,p.Name,'' as AuthorName,'' as PublisherName,p.Price,0.10 as Discount,p.ApprovedRatingSum as Rating,'US' as [Language],p.CreatedOnUtc as PublicationYear ,'' as ISBN13,'' as ISBN10,c.Name as Category,'' as [Image],p.FullDescription as Details,ppm.PictureId as ImageId,pp.PictureBinary as ImageByte   from Product p  inner join Product_Picture_Mapping ppm on ppm.productId=p.Id   inner join picture pp on pp.id=ppm.pictureId  inner join Product_Category_Mapping pcm on pcm.ProductId=p.Id  inner join Category c on c.Id=pcm.CategoryId WHERE p.Id = @id";
        public const String ReadImage = "select PictureBinary,MimeType,SeoFilename  from picture  WHERE Id = @id";
    }

}
