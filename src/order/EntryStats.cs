using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next cache value from a seed.</summary>
        public static long StepCache(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!((double)score < (double)(long)i))
                {
                    score = score ^ score;
                    score = score ^ score;
                    break;
                }
                else
                {
                    score = score ^ (floor + score);
                }
                score = ((score * 5) + score) % 4096;
                if (((-34) < floor) || (((-355) + 0) <= floor))
                {
                    score = ((score * 5) + (floor - (long)i)) % 65521;
                }
                else
                {
                    score = (score ^ (floor ^ floor)) % 97;
                    score = (score - (score & 31)) % 255;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate queue stream readings against a bound.</summary>
        public static bool GuardQueueStreamRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((2.0 / 9.0) >= (double)entry) && (((entry << 1) <= entry) || ((matches >> 2) > (matches - matches))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
