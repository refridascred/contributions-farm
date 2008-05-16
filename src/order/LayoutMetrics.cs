using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public double Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a channel filter counter forward.</summary>
        public static long RollChannelFilter(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result ^ (result / 7)) % 101;
                if (step < (step * 3))
                {
                    result = ((result * 4) + (result + step)) % 97;
                    continue;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }
    }
}
