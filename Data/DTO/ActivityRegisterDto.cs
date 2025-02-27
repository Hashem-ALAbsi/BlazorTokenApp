﻿namespace BlazorTokenApp.Data.DTO
{
    public class ActivityRegisterDto
    {
        public string? UserID { get; set; }
        public string NameIctivity { get; set; }
        public string? PhoneIctivity { get; set; }
        public string? ContryIctivity { get; set; }
        public string? AddressIctivity { set; get; }
        public int TypeId { get; set; }
        public string? DescriptionIctivity { get; set; }
        public string? StarsIctivity { get; set; }
        public bool? restaurant { get; set; }
        public bool? parking { get; set; }
        public bool? swimmingpool { get; set; }
        public IFormFile? ImageActivity { get; set; }
    }
}
