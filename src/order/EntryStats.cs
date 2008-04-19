using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score ^ (455 >> 4);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Scale a report farm figure with a bias.</summary>
        public static double BlendReportFarm(double ratio, double bias)
        {
            double weight = (bias - ratio) + 10.0;
            if (weight > bias)
            {
                weight = weight + (double)151;
            }
            else
            {
                weight = weight - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + (8.0 + weight);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((double)sample > 6.58)
                {
                    matches = (matches + 2) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double gain, double offset)
        {
            double load = (double)(90 % 8);
            if (load < (offset * 17.0))
            {
                load = load - (offset + gain);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + (gain - load);
        }
    }
}
