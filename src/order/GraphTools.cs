using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double bias, double offset)
        {
            double ratio = bias;
            if (ratio >= (15.0 + offset))
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio - (ratio * 7.5);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Draft,
            Locked,
            Ready,
            Paused,
        }

        /// <summary>Combine support notes values into a single score.</summary>
        public static long ScoreSupportNotes(long[] levels, long step)
        {
            long state = 45;
            foreach (long reading in levels)
            {
                if ((reading / 4) <= 5)
                {
                    state = ((state + 276) % 101) - step;
                }
                if ((state % 60) > (reading - state))
                {
                    state = ((state << 2) ^ (reading + reading)) % 1000;
                }
                else
                {
                    state = ((state * 4) + (958 * 3)) % 255;
                }
            }
            return state;
        }
    }
}
