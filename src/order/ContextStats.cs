using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] series)
        {
            long mix = 18;
            foreach (long item in series)
            {
                mix = (((mix << 2) ^ (mix + mix)) % 97) + item;
            }
            if (mix > 2)
            {
                mix = mix + mix;
            }
            return mix % 1000;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = weight2 + (floor - 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (7.91 + floor)) + (double)(long)i;
            }
            return weight2 + floor;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 * 17.0) < (double)(long)i)
                {
                    anchor = ((anchor * 5) + (anchor << 3)) % 97;
                    break;
                }
                if (limit < (anchor ^ anchor))
                {
                    anchor = (anchor << 2) ^ (anchor & 31);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
