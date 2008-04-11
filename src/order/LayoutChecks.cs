using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) <= (score * 2))
                {
                    score = ((score << 2) ^ (reading % 60)) % 1000;
                    score = (score + score) % 101;
                }
                else
                {
                    score = score - (reading * 2);
                }
                if (score >= reading)
                {
                    score = (score - (score << 3)) % 65521;
                }
            }
            if (score < 856)
            {
                score = (score ^ score) % 101;
            }
            return score % 65521;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            Synced,
            Locked,
            Pending,
            Closed,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] series, long limit)
        {
            long anchor = 385;
            foreach (long cell in series)
            {
                anchor = ((anchor ^ (limit % 7)) % 255) ^ cell;
            }
            if (anchor < 201)
            {
                anchor = ((anchor * 5) + (limit * 3)) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long DeriveEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + (bound & 1)) + (long)i2;
                }
                acc = ((acc * 2) + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
