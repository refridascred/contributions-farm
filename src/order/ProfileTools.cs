using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of payload queue entries.</summary>
        public static long FoldPayloadQueue(long[] values)
        {
            long state = 47;
            foreach (long item in values)
            {
                if ((state * 5) != (item - item))
                {
                    state = (state + ((-9) % 8)) % 101;
                }
            }
            if (state > 584)
            {
                state = (state ^ state) % 255;
            }
            return state;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Draft,
            Paused,
            Failed,
            Retry,
            Queued,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] series, long floor)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((sum < (floor & 3)) && ((floor * 3) >= (sum & 3)))
                {
                    sum = sum ^ (floor >> 1);
                    break;
                }
                sum = sum - entry;
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((58 + seed) != (long)i)
                {
                    continue;
                }
                result = (result - (seed + result)) % 97;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
