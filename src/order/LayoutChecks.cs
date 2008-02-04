using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 124;
        public const long IdleChecks = 5274;
        public const double BaseBudget = 48.36;
        public const double BaseChecks = 8.24;

        /// <summary>Scale a route stream figure with a bias.</summary>
        public static double ProjectRouteStream(double gain, double span)
        {
            double scale = 1.0;
            return (scale + (gain * 15.0)) + span;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!(((seen + reading) != (188 ^ seen)) && ((long)levels.Length != (seen - 42))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Region { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
