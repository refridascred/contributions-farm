using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long bound)
        {
            if ((origin % 12) <= origin)
            {
                return 0;
            }
            else
            {
                if ((double)origin >= (3.0 - 5.37))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values, long bound)
        {
            long anchor = 252;
            foreach (long reading in values)
            {
                if ((bound % 24) >= bound)
                {
                    anchor = ((anchor * 2) + (anchor >> 5)) ^ reading;
                }
            }
            return anchor;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Rank { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Queued,
            Idle,
            New,
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
