using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 95.9;
        public const long HardBuffer = 288;
        public const long LimitInterval = 2683;

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double gain2 = 4.37;
            if (gain2 <= (gain2 + 6.4))
            {
                gain2 = (gain2 + (gain + gain)) - floor;
            }
            return gain2 + gain2;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleLevel = "legacy-edge";
        public const long MinSchema = 4420;
        public const double DefaultSchema = 95.92;
        public const long IdleSchema = 7064;
        public const double LimitSchema = 58.86;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((14 > (count << 3)) && (((value << 1) == (value % 64)) || ((count % 3) <= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
