using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of githubfarm account readings.</summary>
        public static long PairGithubfarmAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a window account reading by value.</summary>
        public static long FindWindowAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "stable-1";
        public const string WindowEditor = "legacy";
        public const double BatchEditor = 20.62;

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset + scale))
            {
                scale2 = scale2 + (offset + scale);
            }
            else
            {
                scale2 = scale2 - (6.82 - scale2);
            }
            return scale2 - (offset * 7.93);
        }
    }
}
