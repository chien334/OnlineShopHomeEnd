namespace Model.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }
        [Display(Name = "Tên Người Dùng")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Display(Name = "Mật Khẩu")]
        [StringLength(32)]
        public string Password { get; set; }
        [Display(Name = "Nhóm Người Dùng")]
        [StringLength(20)]
        public string GroupID { set; get; }
        [Display(Name = "Tên")]
        [StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Địa Chỉ Nhà")]
        [StringLength(50)]
        public string Address { get; set; }
        [Display(Name = "E-Mail")]
        [StringLength(50)]
        public string Email { get; set; }
        [Display(Name = "Điện Thoại")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Display(Name = "Tỉnh Thành ")]
        public int? ProvinceID { set; get; }
        [Display(Name = "Huyện")]
        public int? DistrictID { set; get; }
        [Display(Name = "Ngày Tạo")]
        public DateTime? CreatedDate { get; set; }
        [Display(Name = "Người Tạo")]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Display(Name = "Ngày Sửa Đổi")]
        public DateTime? ModifiedDate { get; set; }
        [Display(Name = "Người Sửa Đổi")]
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        [Display(Name = "Trạng Thái")]
        public bool Status { get; set; }
    }
}
