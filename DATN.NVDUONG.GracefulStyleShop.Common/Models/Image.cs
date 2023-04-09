﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.NVDUONG.GracefulStyleShop.Common.Models
{
    public class Image
    {
        public Guid ImageId { get; set; }
        public string ImageName { get; set; }
        public string ImageLink { get; set; }
        public Guid ProductId { get; set; }
    }
}
