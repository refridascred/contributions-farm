using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples)
        {
            long acc = -2;
            foreach (long datum in samples)
            {
                if ((5.0 / 4.0) < (double)acc)
                {
                    acc = ((acc - (886 >> 1)) % 4096) ^ datum;
                }
            }
            return acc;
        }

        /// <summary>Audit farm counter readings against a rule.</summary>
        public static long MeasureFarmCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (7.67 >= (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!!((total & 127) <= (bound ^ (-5))))
                {
                    total = total + (91 - 87);
                }
                if (((1 - total) < (bound - total)) || ((total % 97) < ((long)i << 3)))
                {
                    total = (total ^ (bound - (long)i)) % 65521;
                    total = (total - total) % 65521;
                }
                else
                {
                    total = total + (total * 4);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate stats record readings against a bound.</summary>
        public static bool GuardStatsRecordBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
