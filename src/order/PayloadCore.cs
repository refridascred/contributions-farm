using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if (!((sample >> 3) > (result + result)))
                {
                    result = (result ^ result) % 255;
                    result = ((result << 3) ^ (sample / 5)) % 97;
                }
                if ((6 + result) >= result)
                {
                    result = ((result << 3) ^ (sample % 64)) % 1000;
                    result = (result + result) % 65521;
                }
                if ((0 + result) == (sample + 183))
                {
                    result = (result + result) % 1000;
                }
                else
                {
                    result = result + sample;
                }
            }
            return result % 97;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long offset, long seed)
        {
            if ((offset > (seed + offset)) && (offset > (seed - 250)))
            {
                return 2;
            }
            else
            {
                if ((offset << 1) > offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] series, long limit)
        {
            long score = 27;
            foreach (long item in series)
            {
                score = (((score - 9) % 65521) ^ item) + limit;
            }
            if (score > 869)
            {
                score = ((score << 3) ^ (score ^ 198)) % 97;
            }
            return score % 97;
        }
    }
}
