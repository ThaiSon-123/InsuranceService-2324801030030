--
-- PostgreSQL database cluster dump
--

\restrict oZ8s6slMiKiYI7c3WIOEG0F0kaJa9QSrohYCIRNeFsa6Vo7XxZVkMQVHPH1TdTY

SET default_transaction_read_only = off;

SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;

--
-- Roles
--

CREATE ROLE lab_user;
ALTER ROLE lab_user WITH NOSUPERUSER INHERIT NOCREATEROLE NOCREATEDB LOGIN NOREPLICATION NOBYPASSRLS PASSWORD 'SCRAM-SHA-256$4096:eaxHbkBkHfCY2CWZJY927g==$44NLIVhmJEM3COFLXg2ul4S3u/WaIvHeG02EQV8MlcE=:a5XovQbB1JyCsRRYDc7QMUJFg9NhkBLNCcFltjlhGko=';
CREATE ROLE postgres;
ALTER ROLE postgres WITH SUPERUSER INHERIT CREATEROLE CREATEDB LOGIN REPLICATION BYPASSRLS PASSWORD 'SCRAM-SHA-256$4096:2mI5+WpBeBQ7VzaR9eIqjw==$zyo1xuy7Kry1ca6UmVydPU4wfyezx7Mu9KHXRytASJk=:kCgd+zZiZUiVMJ0x+xeBV7GG5qBZbrShe97PC7uMUJg=';

--
-- User Configurations
--








\unrestrict oZ8s6slMiKiYI7c3WIOEG0F0kaJa9QSrohYCIRNeFsa6Vo7XxZVkMQVHPH1TdTY

--
-- Databases
--

--
-- Database "template1" dump
--

\connect template1

--
-- PostgreSQL database dump
--

\restrict PAbQtnlczzBCCF3qev56oUSCkALRwsK7I5K5pCsD2qwbYBx2t2B4tLiman9Qprh

-- Dumped from database version 15.19 (Debian 15.19-1.pgdg13+2)
-- Dumped by pg_dump version 15.19 (Debian 15.19-1.pgdg13+2)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- PostgreSQL database dump complete
--

\unrestrict PAbQtnlczzBCCF3qev56oUSCkALRwsK7I5K5pCsD2qwbYBx2t2B4tLiman9Qprh

--
-- Database "lab_netmicro_jobs" dump
--

--
-- PostgreSQL database dump
--

\restrict PyNb5GUMvA0C2yauGKb9NEVrYoWhjbIQw3f7MgMmP0ViI74GjTqS3O9CEsHYhng

-- Dumped from database version 15.19 (Debian 15.19-1.pgdg13+2)
-- Dumped by pg_dump version 15.19 (Debian 15.19-1.pgdg13+2)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: lab_netmicro_jobs; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE lab_netmicro_jobs WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';


ALTER DATABASE lab_netmicro_jobs OWNER TO postgres;

\unrestrict PyNb5GUMvA0C2yauGKb9NEVrYoWhjbIQw3f7MgMmP0ViI74GjTqS3O9CEsHYhng
\connect lab_netmicro_jobs
\restrict PyNb5GUMvA0C2yauGKb9NEVrYoWhjbIQw3f7MgMmP0ViI74GjTqS3O9CEsHYhng

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: DATABASE lab_netmicro_jobs; Type: ACL; Schema: -; Owner: postgres
--

GRANT ALL ON DATABASE lab_netmicro_jobs TO lab_user;


--
-- PostgreSQL database dump complete
--

\unrestrict PyNb5GUMvA0C2yauGKb9NEVrYoWhjbIQw3f7MgMmP0ViI74GjTqS3O9CEsHYhng

--
-- Database "lab_netmicro_payments" dump
--

--
-- PostgreSQL database dump
--

\restrict olmKxuClafyyzIjXLzVUGULDfx0jWVXODbNbKxBDwuwnhGhOK6KDmGe8xmxfOMj

-- Dumped from database version 15.19 (Debian 15.19-1.pgdg13+2)
-- Dumped by pg_dump version 15.19 (Debian 15.19-1.pgdg13+2)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: lab_netmicro_payments; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE lab_netmicro_payments WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';


ALTER DATABASE lab_netmicro_payments OWNER TO postgres;

\unrestrict olmKxuClafyyzIjXLzVUGULDfx0jWVXODbNbKxBDwuwnhGhOK6KDmGe8xmxfOMj
\connect lab_netmicro_payments
\restrict olmKxuClafyyzIjXLzVUGULDfx0jWVXODbNbKxBDwuwnhGhOK6KDmGe8xmxfOMj

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: DATABASE lab_netmicro_payments; Type: ACL; Schema: -; Owner: postgres
--

GRANT ALL ON DATABASE lab_netmicro_payments TO lab_user;


--
-- PostgreSQL database dump complete
--

\unrestrict olmKxuClafyyzIjXLzVUGULDfx0jWVXODbNbKxBDwuwnhGhOK6KDmGe8xmxfOMj

--
-- Database "lab_netmicro_policy" dump
--

--
-- PostgreSQL database dump
--

\restrict 1HOWLUjmrRrv1pcSha4LgWsT2ZYBUbKQ8EHwlcqxbvf38xG4g8odS1jGzMc6cX6

-- Dumped from database version 15.19 (Debian 15.19-1.pgdg13+2)
-- Dumped by pg_dump version 15.19 (Debian 15.19-1.pgdg13+2)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: lab_netmicro_policy; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE lab_netmicro_policy WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';


ALTER DATABASE lab_netmicro_policy OWNER TO postgres;

\unrestrict 1HOWLUjmrRrv1pcSha4LgWsT2ZYBUbKQ8EHwlcqxbvf38xG4g8odS1jGzMc6cX6
\connect lab_netmicro_policy
\restrict 1HOWLUjmrRrv1pcSha4LgWsT2ZYBUbKQ8EHwlcqxbvf38xG4g8odS1jGzMc6cX6

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: DATABASE lab_netmicro_policy; Type: ACL; Schema: -; Owner: postgres
--

GRANT ALL ON DATABASE lab_netmicro_policy TO lab_user;


--
-- PostgreSQL database dump complete
--

\unrestrict 1HOWLUjmrRrv1pcSha4LgWsT2ZYBUbKQ8EHwlcqxbvf38xG4g8odS1jGzMc6cX6

--
-- Database "lab_netmicro_pricing" dump
--

--
-- PostgreSQL database dump
--

\restrict J09wqizDjnyr7F0IHpKPx9zwpTDz33oPNHDbtGbwYtzcOlJiThHZN1fhMzBTM9q

-- Dumped from database version 15.19 (Debian 15.19-1.pgdg13+2)
-- Dumped by pg_dump version 15.19 (Debian 15.19-1.pgdg13+2)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: lab_netmicro_pricing; Type: DATABASE; Schema: -; Owner: postgres
--

CREATE DATABASE lab_netmicro_pricing WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en_US.utf8';


ALTER DATABASE lab_netmicro_pricing OWNER TO postgres;

\unrestrict J09wqizDjnyr7F0IHpKPx9zwpTDz33oPNHDbtGbwYtzcOlJiThHZN1fhMzBTM9q
\connect lab_netmicro_pricing
\restrict J09wqizDjnyr7F0IHpKPx9zwpTDz33oPNHDbtGbwYtzcOlJiThHZN1fhMzBTM9q

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: DATABASE lab_netmicro_pricing; Type: ACL; Schema: -; Owner: postgres
--

GRANT ALL ON DATABASE lab_netmicro_pricing TO lab_user;


--
-- PostgreSQL database dump complete
--

\unrestrict J09wqizDjnyr7F0IHpKPx9zwpTDz33oPNHDbtGbwYtzcOlJiThHZN1fhMzBTM9q

--
-- Database "postgres" dump
--

\connect postgres

--
-- PostgreSQL database dump
--

\restrict M9rbGQGXBL4b8Rh52KwPv683pM8VGEoUCgjdbb51Z39BfzoBnCSVeOKk6qWeuzI

-- Dumped from database version 15.19 (Debian 15.19-1.pgdg13+2)
-- Dumped by pg_dump version 15.19 (Debian 15.19-1.pgdg13+2)

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- PostgreSQL database dump complete
--

\unrestrict M9rbGQGXBL4b8Rh52KwPv683pM8VGEoUCgjdbb51Z39BfzoBnCSVeOKk6qWeuzI

--
-- PostgreSQL database cluster dump complete
--

