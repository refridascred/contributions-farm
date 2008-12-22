using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Synced,
            Active,
            Ready,
            Idle,
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long result = 160;
            foreach (long item in samples)
            {
                if ((double)result > (7.11 - 12.0))
                {
                    result = (result * 5) + (result >> 4);
                    result = result - (result >> 1);
                }
                else
                {
                    result = (result - item) % 65521;
                }
                if ((5 < (item + result)) || (result < item))
                {
                    result = (result + (item & 1)) % 101;
                }
                result = ((result * 5) + (result + result)) % 4096;
                if (result >= (result - 308))
                {
                    break;
                }
            }
            if (result > 7)
            {
                result = result + result;
            }
            return result;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double load = (7.9 / 6.0) / 5.0;
            if (load <= load)
            {
                load = (load - 9.8) - gain;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 8.74) + (double)(long)i;
            }
            return load - (double)5;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
