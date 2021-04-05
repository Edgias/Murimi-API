﻿using Murimi.API.Interfaces;
using Murimi.API.Models.Request;
using Murimi.API.Models.Response;
using Murimi.ApplicationCore.Entities;
using System;

namespace Murimi.API.ObjectMappers
{
    public class CropVarietyMapper : IMapper<CropVariety, CropVarietyRequestApiModel, CropVarietyApiModel>
    {
        public CropVariety Map(CropVarietyRequestApiModel apiModel)
        {
            CropVariety entity = new CropVariety
            {
                CreatedBy = apiModel.UserId
            };

            Map(entity, apiModel);

            return entity;
        }

        public CropVarietyApiModel Map(CropVariety entity)
        {
            CropVarietyApiModel apiModel = new CropVarietyApiModel
            {
                Id = entity.Id,
                Name = entity.Name,
                LastModifiedDate = entity.LastModifiedDate,
                CreatedDate = entity.CreatedDate,
                CropId = entity.CropId,
                Crop = entity.Crop?.Name,
                IsActive = entity.IsActive
            };

            return apiModel;
        }

        public void Map(CropVariety entity, CropVarietyRequestApiModel apiModel)
        {
            entity.Name = apiModel.Name;
            entity.CropId = apiModel.CropId;
            entity.LastModifiedBy = apiModel.UserId;
            entity.LastModifiedDate = DateTimeOffset.Now;
        }
    }
}
