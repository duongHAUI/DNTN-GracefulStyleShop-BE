﻿using DATN.NVDUONG.GracefulStyleShop.Common.Models;
using DATN.NVDUONG.GracefulStyleShop.Common.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.NVDUONG.GracefulStyleShop.BL.Interfaces
{
    public interface IAddressReceiveService: IBaseService<AddressReceive>
    {
        public bool SetDefault(AddressReceiveSetDefauModel addressReceiveSetDefauModel);
    }
}
