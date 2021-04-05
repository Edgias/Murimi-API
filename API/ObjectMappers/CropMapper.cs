﻿using Murimi.API.Interfaces;
using Murimi.API.Models.Request;
using Murimi.API.Models.Response;
using Murimi.ApplicationCore.Entities;
using System;

namespace Murimi.API.ObjectMappers
{
    public class CropMapper : IMapper<Crop, CropRequestApiModel, CropApiModel>
    {
        public Crop Map(CropRequestApiModel apiModel)
        {
            Crop entity = new Crop
            {
                CreatedBy = apiModel.UserId
            };

            Map(entity, apiModel);

            return entity;
        }

        public CropApiModel Map(Crop entity)
        {
            CropApiModel apiModel = new CropApiModel
            {
                Id = entity.Id,
                Name = entity.Name,
                CreatedDate = entity.CreatedDate,
                CropCategory = entity.CropCategory?.Name,
                CropCategoryId = entity.CropCategoryId,
                CropUnit = entity.CropUnit?.Name,
                CropUnitId = entity.CropUnitId,
                IsActive = entity.IsActive,
                LastModifiedDate = entity.LastModifiedDate
            };

            return apiModel;
        }

        public void Map(Crop entity, CropRequestApiModel apiModel)
        {
            entity.Name = apiModel.Name;
            entity.CropCategoryId = apiModel.CropCategoryId;
            entity.CropUnitId = apiModel.CropUnitId;
            entity.LastModifiedBy = apiModel.UserId;
            entity.LastModifiedDate = DateTimeOffset.Now;
        }
    }
}