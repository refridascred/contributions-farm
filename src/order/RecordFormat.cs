using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((mix / 3) < (floor & 1))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long floor, long step)
        {
            long next = floor - step;
            if ((step ^ step) > (8 * 2))
            {
                return 2;
            }
            else
            {
                if (!(step < 17))
                {
                    return 5;
                }
                else
                {
                    if ((floor - next) <= (668 - next))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum % 7) >= (datum + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
