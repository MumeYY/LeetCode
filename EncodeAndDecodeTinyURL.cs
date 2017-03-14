// Note: This is a companion problem to the System Design problem: Design TinyURL.
// TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns a short URL such as http://tinyurl.com/4e9iAk.

// Design the encode and decode methods for the TinyURL service. There is no restriction on how your encode/decode algorithm should work. You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.

// Subscribe to see which companies asked this question.
using System.Collections.Generic;
//总体功能来说都是做缓存的思路

public class Codec {

    Dictionary<string, string> m = new Dictionary<string, string>();
    // Encodes a URL to a shortened URL
    public string encode(string longUrl) {
        return "";
    }

    // Decodes a shortened URL to its original URL.
    public string decode(string shortUrl) {
        return "";
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(url));