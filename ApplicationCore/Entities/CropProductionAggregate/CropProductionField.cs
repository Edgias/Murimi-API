using Murimi.ApplicationCore.SharedKernel;
using System;

namespace Murimi.ApplicationCore.Entities.CropProductionAggregate
{
    public class CropProductionField : BaseEntity
    {
        public Guid FieldId { get; private set; }

        public Field Field { get; private set; }

        public Guid CropProductionId { get; private set; }

        public CropProduction CropProduction { get; private set; }

        public CropProductionField(Guid fieldId, Guid cropProductionId)
        {
            Guard.AgainstNull(fieldId, nameof(fieldId));
            Guard.AgainstNull(cropProductionId, nameof(cropProductionId));

            FieldId = fieldId;
            CropProductionId = cropProductionId;
        }
    }
}
