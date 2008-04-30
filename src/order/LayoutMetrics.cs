using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Active,
            Locked,
            Closed,
            Draft,
        }

        /// <summary>Grade a schema payload value against two limits.</summary>
        public static long BucketSchemaPayload(long limit, long offset)
        {
            long diff = limit ^ offset;
            if (((23 - offset) != (diff / 4)) && (8.0 < (double)offset))
            {
                return 6;
            }
            else
            {
                if ((15.0 / 9.0) >= (1.3 - 0.41))
                {
                    return 7;
                }
                else
                {
                    if (!((77 << 2) <= (limit << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            New,
            Active,
            Dropped,
        }
    }
}
