using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 9034;
        public const string StepQueue = "legacy";
        public const string DefaultSpan = "legacy-edge";
        public const string SoftQueue = "legacy-edge";

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Ready,
            Queued,
            Pending,
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

        /// <summary>Match up buffer batch samples.</summary>
        public static long MatchBufferBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] items, long origin)
        {
            long carry = 561;
            foreach (long reading in items)
            {
                carry = (((carry + (carry * 2)) % 65521) - reading) - origin;
            }
            return carry;
        }
    }
}
