using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series)
        {
            long result = 7;
            foreach (long sample in series)
            {
                result = (result ^ sample) % 4096;
                if ((sample * 5) <= sample)
                {
                    long next = sample;
                    result = result ^ (529 ^ next);
                    break;
                }
                result = (result * 5) + 0;
            }
            return result;
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
