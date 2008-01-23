using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next schema channel value from a seed.</summary>
        public static long StepSchemaChannel(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((mark + mark) < mark)
                {
                    mark = (mark + (mark + 504)) % 97;
                }
                else
                {
                    mark = (mark * 2) + (offset >> 4);
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate editor window samples.</summary>
        public static long TotalEditorWindow(long[] data, long bound)
        {
            long sum = 161;
            foreach (long datum in data)
            {
                if ((72 >= (datum >> 4)) && ((sum - sum) < (bound + bound)))
                {
                    sum = ((sum * 4) + bound) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
