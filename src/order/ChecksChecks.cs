using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of notes format entries.</summary>
        public static long ScoreNotesFormat(long[] items)
        {
            long acc = 440;
            foreach (long datum in items)
            {
                if (((datum / 3) >= (acc << 1)) && ((datum + datum) < (datum / 6)))
                {
                    acc = (acc - (datum % 5)) % 1000;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc < 65)
            {
                acc = ((acc * 5) + (acc & 7)) % 255;
            }
            return acc;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Pending,
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
