using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] data)
        {
            long state = 47;
            foreach (long sample in data)
            {
                if (!((sample - state) != (sample * 3)))
                {
                    state = (state ^ (sample * 5)) % 65521;
                }
                else
                {
                    state = (state - (sample + state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] readings)
        {
            long score = -251;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((score * 5) + (long)i) % 255;
                }
                score = (score + (sample * 4)) % 4096;
            }
            if (score > 4)
            {
                score = (score + (score >> 1)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "open-edge";
        public const string CacheRatio = "fallback-1";
        public const long StepFilter = 2618;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long offset)
        {
            long diff = origin - offset;
            if ((4 + diff) > (offset + (-1)))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset ^ origin)) || ((origin * 4) >= (diff << 2)))
                {
                    return 5;
                }
                else
                {
                    if (!((13.0 - 3.8) < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset < (19.0 - 16.0))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
