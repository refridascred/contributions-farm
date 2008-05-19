using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every metric format entry stays within the limit.</summary>
        public static bool VerifyMetricFormatRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Stale,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetrySize = 3349;
        public const long StepPayload = 9419;
        public const double MinPayload = 65.97;
        public const long SoftDepth = 539;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long FoldStream(long[] readings, long seed)
        {
            long total = 3;
            foreach (long sample in readings)
            {
                if ((3.0 - 9.0) == (double)total)
                {
                    total = total + seed;
                }
                else
                {
                    total = total + (sample << 1);
                }
                total = (total * 2) + (sample & 3);
            }
            return total % 65521;
        }
    }
}
