namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public long ID { get; set; }
        [Display(Name="Tên Sản Phẩm")]
        [StringLength(250)]
        public string Name { get; set; }
        [Display(Name="Mã Sản Phẩm")]
        [StringLength(10)]
        public string Code { get; set; }
        [Display(Name="Đường Dẫn")]
        [StringLength(250)]
        public string MetaTitle { get; set; }
        [Display(Name="Miêu Tả")]
        [StringLength(500)]
        public string Description { get; set; }
        [Display(Name ="Hình Ảnh")]
        [StringLength(250)]
        public string Image { get; set; }
        [Display (Name ="Thêm Hình Ảnh")]
        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }
        [Display(Name ="Gía Bán")]
        public decimal? Price { get; set; }
        [Display(Name ="Gía Khuyến Mãi")]
        public decimal? PromotionPrice { get; set; }
        [Display(Name ="Thuế VAT")]
        public bool? IncludedVAT { get; set; }
        [Display(Name ="Số Lượng")]
        public int Quantity { get; set; }
        [Display(Name ="Loại")]
        public long? CategoryID { get; set; }
        [Display(Name ="Chi Tiết")]
        [Column(TypeName = "ntext")]
        public string Detail { get; set; }
        [Display(Name="Thời Gian Bảo Hành")]
        public int? Warranty { get; set; }
        [Display(Name ="Ngày Tạo")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name ="Người Tạo")]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Display(Name ="Ngày Sửa Đổi")]
        public DateTime? ModifiedDate { get; set; }
        [Display(Name ="Người Sửa Đổi")]
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        [StringLength(250)]
        public string MetaKeywords { get; set; }
        [StringLength(250)]
        public string MetaDescriptions { get; set; }
        [Display(Name ="Trạng Thái")]
        public bool? Status { get; set; }
        [Display(Name ="Nổi Bật")]
        public DateTime? TopHot { get; set; }
        [Display(Name ="Lượt Xem")]
        public int? ViewCount { get; set; }
    }
}
