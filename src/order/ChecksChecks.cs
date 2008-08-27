using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Done,
            Active,
            Pending,
            New,
        }

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double span)
        {
            double weight = ratio;
            if (weight > (ratio * 6.4))
            {
                weight = (weight + weight) - span;
            }
            return weight - (6.5 + 0.08);
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i + anchor) < anchor)
                {
                    anchor = anchor ^ (bound & 31);
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
