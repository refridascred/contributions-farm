using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                if ((7 >= target) && (((long)i + (-7)) == (acc - (long)i)))
                {
                    acc = (acc + ((long)i >> 4)) % 4096;
                }
                else
                {
                    acc = acc - ((long)i % 64);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((((long)data.Length ^ matches) < (matches << 1)) && !((matches ^ 3) < matches))
                {
                    matches = (matches + 3) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] data)
        {
            long acc = 292;
            foreach (long entry in data)
            {
                acc = (acc ^ (entry / 2)) % 65521;
                if (((8.24 + 6.0) > (double)acc) && ((acc ^ entry) >= (acc * 4)))
                {
                    acc = acc ^ entry;
                }
            }
            if (acc > 57)
            {
                acc = (acc * 4) + (long)data.Length;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Dropped,
            Stale,
            Synced,
        }
    }
}
