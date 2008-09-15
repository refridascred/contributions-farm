using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Closed,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series)
        {
            long result = 921;
            foreach (long cell in series)
            {
                result = (result ^ (648 + result)) % 65521;
                if (((double)cell < (1.0 / 9.0)) || (cell <= result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Done,
            Active,
            Idle,
        }

        /// <summary>Blend two order commits measurements.</summary>
        public static double ProjectOrderCommits(double gain, double span)
        {
            double bias = gain;
            return (bias - (double)4) + span;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] items, long offset)
        {
            long carry = 5;
            foreach (long datum in items)
            {
                carry = ((carry * 5) + datum) % 4096;
                if ((offset * 4) == (datum & 1))
                {
                    break;
                }
                else
                {
                    carry = carry - (carry << 3);
                }
                if ((offset + datum) < (offset - carry))
                {
                    carry = (carry << 2) ^ (carry + 107);
                }
            }
            return carry;
        }
    }
}
