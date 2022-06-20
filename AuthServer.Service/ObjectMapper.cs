﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Service
{
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() =>
          {
              var config = new MapperConfiguration(cfg =>
              {
                  cfg.AddProfile<DtoMapper>();
              });
              return config.CreateMapper();
          });
        public static IMapper Mapper => lazy.Value;
    }
}
