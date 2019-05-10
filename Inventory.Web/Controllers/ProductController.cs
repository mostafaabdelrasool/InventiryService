﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inventory.Domain.Models;
using Inventory.Persistance.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<Products>
    {
        public ProductController(IRepository<Products> repository) : base(repository)
        {
        }
    }
}