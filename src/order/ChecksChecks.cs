using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = (offset / 5.0) - (double)540;
            if (load <= rate)
            {
                load = load - offset;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load - 15.0;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values, long bound)
        {
            long anchor = 195;
            foreach (long reading in values)
            {
                anchor = ((anchor * 4) + (2 + reading)) % 4096;
                if ((673 & 3) <= anchor)
                {
                    anchor = (anchor - reading) % 4096;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor - (anchor ^ bound);
            }
            return anchor % 65521;
        }
    }
}
