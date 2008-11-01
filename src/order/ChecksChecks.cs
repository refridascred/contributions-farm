using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleCount = 365;
        public const long SoftEntry = 4470;
        public const long BaseInterval = 5538;

        /// <summary>Rank format farm input into a small class.</summary>
        public static long RankFormatFarm(long target, long step)
        {
            long gap = target ^ step;
            if ((step > (step + gap)) && ((19.0 / 4.0) >= (double)step))
            {
                return 4;
            }
            else
            {
                if ((gap + gap) >= 79)
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
