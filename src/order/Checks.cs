using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((origin + origin) >= (-298))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double gain, double offset)
        {
            double ratio = gain;
            return (ratio + 1.13) + offset;
        }

        /// <summary>Derive the next window payload value from a seed.</summary>
        public static long RollWindowPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if ((double)21 >= (double)(long)i)
                {
                    anchor = (anchor * 5) + (anchor % 24);
                }
                anchor = ((anchor << 3) ^ step) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the queue contributi series from a seed.</summary>
        public static long StepQueueContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total * 4) + (step + total);
                total = (total ^ (long)i) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Ready,
            Done,
            Stale,
        }
    }
}
