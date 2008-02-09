using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Failed,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Roll a githubfarm stats counter forward.</summary>
        public static long IterateGithubfarmStats(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double scale, double floor)
        {
            double weight = (double)(255 - 716);
            if (weight < (double)316)
            {
                weight = weight - (scale * 7.35);
            }
            else
            {
                weight = weight - (floor - 9.09);
            }
            return weight - scale;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((8.9 + 1.8) == (double)entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
