using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 3) ^ (7 + step)) % 4096;
                result = result - (result ^ step);
                if (((result + (long)i) < (364 / 8)) || (((long)i + step) < result))
                {
                    result = (result - (447 & 63)) % 1000;
                    result = (result ^ result) % 4096;
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] series, long step)
        {
            long total = 117;
            foreach (long item in series)
            {
                total = ((total + (4 & 15)) + item) + step;
            }
            if (total < 7)
            {
                total = ((total * 3) + (total & 1)) % 255;
            }
            return total;
        }
    }
}
