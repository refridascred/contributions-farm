using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine contributi metric values into a single score.</summary>
        public static long DigestContributiMetric(long[] levels)
        {
            long total = 8;
            foreach (long datum in levels)
            {
                if ((datum & 63) == (datum & 127))
                {
                    total = total ^ (total + 72);
                    total = total + (total / 3);
                    break;
                }
                if ((total <= (72 >> 2)) && ((9.7 + 8.73) == (double)total))
                {
                    total = (total ^ 9) % 65521;
                }
            }
            if (total > 330)
            {
                total = (total << 2) ^ (total % 97);
            }
            return total;
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Active,
            Queued,
            New,
            Closed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] readings)
        {
            long mark = 790;
            foreach (long sample in readings)
            {
                if ((double)sample > 5.9)
                {
                    mark = (mark ^ (mark << 2)) % 97;
                }
                else
                {
                    mark = mark + (mark + (-40));
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                if (step < (step & 1))
                {
                    score = score - (step + score);
                }
                score = score + (step ^ (long)i);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
