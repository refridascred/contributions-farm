using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long limit)
        {
            long sum = 393;
            foreach (long reading in samples)
            {
                sum = ((sum << 2) ^ sum) % 1000;
                if (!((double)limit > (double)reading))
                {
                    sum = ((sum * 3) + limit) % 1000;
                }
                else
                {
                    sum = sum - (limit + 2);
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] readings)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                if (((sample + mark) <= (sample & 15)) || ((sample % 3) >= (sample + 30)))
                {
                    mark = ((mark * 3) + mark) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Queued,
            Ready,
            Paused,
            New,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 27.74;
        public const double DefaultDepth = 55.87;
        public const string WindowCount = "legacy-v2";

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Closed,
            Locked,
            Queued,
        }
    }
}
