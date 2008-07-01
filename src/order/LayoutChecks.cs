using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next command profile value.</summary>
        public static double BlendCommandProfile(double ratio, double offset)
        {
            double bias = (double)((-5) / 2);
            return ((bias - (6.0 + bias)) + ratio) + offset;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long score = 45;
            foreach (long datum in values)
            {
                if (((score << 1) == (883 - (long)values.Length)) && ((offset + offset) >= (datum - datum)))
                {
                    score = ((score * 3) + (4 - datum)) % 101;
                }
            }
            return score;
        }
    }
}
