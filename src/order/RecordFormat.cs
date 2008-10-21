using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] readings)
        {
            long score = 89;
            foreach (long sample in readings)
            {
                score = (score << 3) ^ (score << 2);
                score = (score << 2) ^ (sample + (-9));
                if ((sample + score) >= (score ^ 56))
                {
                    break;
                }
            }
            if (score > (-10))
            {
                score = (score << 2) ^ (score >> 4);
            }
            return score;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen >> 1) <= offset)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long origin)
        {
            long result = 934;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result * 4) + ((long)i >> 4);
                }
                result = result - (9 ^ origin);
                if (((datum + result) >= origin) && ((double)result < 0.2))
                {
                    result = (result + (result + datum)) % 4096;
                }
            }
            return result % 4096;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long target, long seed)
        {
            if ((8.0 + 7.19) == (double)seed)
            {
                return 8;
            }
            else
            {
                if (96 < seed)
                {
                    return 0;
                }
                else
                {
                    if (!(seed >= (target - target)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((19.0 * 7.8) == (double)target) && ((59 ^ target) > (target - seed)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
