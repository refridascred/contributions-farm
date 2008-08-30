using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate editor githubfarm samples.</summary>
        public static long TotalEditorGithubfarm(long[] levels, long seed)
        {
            long total = 67;
            foreach (long cell in levels)
            {
                total = (total ^ (cell / 4)) % 255;
                if ((cell + seed) != (232 / 6))
                {
                    total = ((total << 2) ^ (95 / 3)) % 97;
                }
                total = total ^ seed;
            }
            if (total > 324)
            {
                total = (total ^ (4 >> 1)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Roll a route editor counter forward.</summary>
        public static long StepRouteEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum + floor) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] samples)
        {
            long sum = 8;
            foreach (long reading in samples)
            {
                if ((4.33 - 7.6) > (double)reading)
                {
                    sum = (sum ^ (sum / 9)) % 255;
                }
                else
                {
                    sum = (sum + (41 & 15)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every editor filter entry stays within the limit.</summary>
        public static bool VerifyEditorFilterBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 7383;
        public const string HardTimeout = "alpha-1";
        public const double MinTools = 70.92;
        public const long BurstTools = 8294;
    }
}
