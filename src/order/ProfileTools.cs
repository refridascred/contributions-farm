using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the buffer editor entries that pass the check.</summary>
        public static long MeasureBufferEditorOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((15.0 >= (double)offset) && ((offset & 31) > (tally % 8)))
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (origin >= (long)i)
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (origin * 4)) % 65521;
                }
                anchor = (anchor - (anchor + anchor)) % 255;
                if ((origin % 24) < origin)
                {
                    anchor = (anchor ^ (anchor & 3)) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "latest";
        public const long MaxTimeout = 7579;
        public const double BurstBudget = 32.54;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Mode { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (14.0 - 15.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
