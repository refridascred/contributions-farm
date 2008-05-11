using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a route githubfarm reading by value.</summary>
        public static long FindRouteGithubfarmIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long carry = -7;
            foreach (long reading in samples)
            {
                carry = carry ^ (reading & 3);
                if (!((step ^ reading) >= carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 2.2;
            if (load <= (ratio - load))
            {
                load = load + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (4.89 / 8.0)) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Failed,
            Paused,
            Queued,
        }
    }
}
