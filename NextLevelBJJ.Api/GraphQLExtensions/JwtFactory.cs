using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace NextLevelBJJ.Api.GraphQLExtensions
{
    public class JwtFactory
    {

        private IJwtAlgorithm _algorithm;
        private IJsonSerializer _serializer;
        private IBase64UrlEncoder _urlEncoder;
        private const string _secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";

        public JwtFactory()
        {
            _algorithm = new HMACSHA256Algorithm();
            _serializer = new JsonNetSerializer();
            _urlEncoder = new JwtBase64UrlEncoder();

        }

        public string BuildToken(string carnetGuid)
        {
            IJwtEncoder _encoder = new JwtEncoder(_algorithm, _serializer, _urlEncoder);
            var payload = new Dictionary<string, object>
                {
                    { "carnetGuid", carnetGuid },
                    { "exp",  DateTimeOffset.Now.AddSeconds(10).ToUnixTimeMilliseconds() }
                };

            return _encoder.Encode(payload, _secret);
        }

        public string GetCarnetIdFromToken(string token)
        {
            if (IsTokenValid(token))
                return "";

            IDateTimeProvider provider = new UtcDateTimeProvider();
            IJwtValidator validator = new JwtValidator(_serializer, provider);
            IJwtDecoder decoder = new JwtDecoder(_serializer, validator, _urlEncoder);

            var payload = decoder.DecodeToObject<IDictionary<string, object>>(token);

            return payload["carnetGuid"].ToString();
        }

        private bool IsTokenValid(string token)
        {
            try
            {
                IDateTimeProvider provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(_serializer, provider);
                IJwtDecoder decoder = new JwtDecoder(_serializer, validator, _urlEncoder);

                var json = decoder.Decode(token, _secret, verify: true);
            }
            catch (TokenExpiredException)
            {
                return false;
            }
            catch (SignatureVerificationException)
            {
                return false;
            }

            return true;
        }


    }
}
