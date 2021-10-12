using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebAppCore.Data.Enums;
using WebAppCore.Data.Interfaces;
using WebAppCore.Infrastructure.SharedKernel;

namespace WebAppCore.Data.Entities
{
    [Table("ProductCategories")]
    public class ProductCategory : DomainEntity<int>, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public string Name { set; get; }
        public string Description { set; get; }
        public int? ParentId { get; set; }
        public int? HomeOrder { get; set; }
        public string Image { get; set; }
        public bool? HomeFlag { get; set; }

        public string SeoPageTitle { set; get; }
        public string SeoAlias  { set; get; }
        public string SeoKeywords  { set; get; }
        public string SeoDescription  { set; get; }
        public Status Status  { set; get; }
        public int SortOrder  { set; get; }
        public DateTime DateCreated  { set; get; }
        public DateTime DateModified  { set; get; }

        public virtual ICollection<Product> Products { set; get; }
    }
}
