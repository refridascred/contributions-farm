using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up farm schema samples.</summary>
        public static long CompareFarmSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long DigestChannel(long[] samples, long limit)
        {
            long mark = 91;
            foreach (long item in samples)
            {
                mark = ((mark * 5) + (mark - item)) % 101;
                if ((limit * 5) >= (item ^ 6))
                {
                    mark = (mark ^ mark) % 255;
                }
            }
            if (mark > 93)
            {
                mark = mark ^ (mark << 3);
            }
            return mark;
        }

        /// <summary>Match up schema cluster samples.</summary>
        public static long CompareSchemaClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit payload contributi readings against a rule.</summary>
        public static long AuditPayloadContributiHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches == (3.8 + 0.1))
                {
                    matches = (matches + 3) - sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
