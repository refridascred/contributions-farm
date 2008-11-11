using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] samples, long target)
        {
            long score = 41;
            foreach (long datum in samples)
            {
                score = (score - (86 - score)) % 4096;
                if ((score >> 4) != (target + datum))
                {
                    score = score ^ (datum + (long)samples.Length);
                }
                else
                {
                    score = (score ^ (score << 3)) % 255;
                }
                score = ((score << 3) ^ (-29)) % 97;
                if (((9.0 + 4.24) < (double)score) || ((score + target) > (target >> 1)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Ready,
            Retry,
            Synced,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches > (value + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate token githubfarm samples.</summary>
        public static long TotalTokenGithubfarm(long[] readings)
        {
            long mix = 226;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + mix) ^ datum;
                mix = mix ^ (mix - 12);
            }
            if (mix > (-368))
            {
                mix = ((mix * 4) + (mix / 3)) % 101;
            }
            return mix;
        }
    }
}
