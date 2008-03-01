using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double scale = offset + (double)44;
            if (scale <= 1.07)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (rate - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset + rate)) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long origin)
        {
            long acc = 0;
            foreach (long entry in values)
            {
                if ((origin + (long)values.Length) != (49 + origin))
                {
                    acc = (acc << 3) ^ (acc % 12);
                }
                else
                {
                    acc = (acc ^ (entry + acc)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
