using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many githubfarm filter samples are out of range.</summary>
        public static long AuditGithubfarmFilterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum - count) != (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] levels)
        {
            long score = 32;
            foreach (long cell in levels)
            {
                if ((17.0 * 2.78) != (double)cell)
                {
                    score = (score ^ (cell & 31)) % 65521;
                }
                score = (score + (30 - cell)) % 1000;
                if (((score + cell) >= (score << 3)) || ((cell / 5) >= (cell + cell)))
                {
                    score = (score << 3) ^ (cell ^ score);
                }
            }
            return score % 4096;
        }

        /// <summary>Match up cluster schema samples.</summary>
        public static long OverlapClusterSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Draft,
            Active,
            Synced,
        }
    }
}
