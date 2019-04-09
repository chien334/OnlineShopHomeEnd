namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Content")]
    public partial class Content
    {
        public long ID { get; set; }
        [Display(Name ="Tên Sản Phẩm")]
        [StringLength(250)]
        public string Name { get; set; }
        [Display(Name ="Đường Dẫn")]
        [StringLength(250)]
        public string MetaTitle { get; set; }
        [Display(Name ="Miêu Tả")]
        [StringLength(500)]
        public string Description { get; set; }
        [Display(Name ="Hình Ảnh")]
        [StringLength(250)]
        public string Image { get; set; }
        [Display(Name ="Loại")]
        public long? CategoryID { get; set; }
        [Display(Name ="Chi Tiết")]
        [Column(TypeName = "ntext")]
        public string Detail { get; set; }
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
        [Display(Name ="Mô Tả")]
        [StringLength(250)]
        public string MetaDescriptions { get; set; }
        [Display(Name ="Trạng Thái")]
        public bool Status { get; set; }
        [Display(Name ="Nổi Bật")]
        public DateTime? TopHot { get; set; }
        [Display(Name ="Lượt Xem")]
        public int? ViewCount { get; set; }
        [Display(Name ="Thẻ")]
        [StringLength(500)]
        public string Tags { get; set; }
        [Display(Name ="Ngôn Ngữ")]
        public string Language { set; get; }
    }
}
