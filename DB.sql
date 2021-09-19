-- Database: TourPlannerDataBaseCS

-- DROP DATABASE "TourPlannerDataBaseCS";

CREATE DATABASE "TourPlannerDataBaseCS"
    WITH 
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'English_United States.1252'
    LC_CTYPE = 'English_United States.1252'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

-- Table: public.Log

-- DROP TABLE public."Log";

CREATE TABLE public."Log"
(
    "LogID" integer NOT NULL,
    "TourID" integer NOT NULL,
    "Rating" integer,
    "Date" text COLLATE pg_catalog."default",
    "Momentum" text COLLATE pg_catalog."default",
    "Distance" text COLLATE pg_catalog."default",
    "TotalTime" text COLLATE pg_catalog."default",
    "Torque" text COLLATE pg_catalog."default",
    "Joule" text COLLATE pg_catalog."default",
    CONSTRAINT "Log_pkey" PRIMARY KEY ("LogID")
)

TABLESPACE pg_default;

ALTER TABLE public."Log"
    OWNER to postgres;

-- Table: public.Tour

-- DROP TABLE public."Tour";

CREATE TABLE public."Tour"
(
    "TourID" bigint NOT NULL DEFAULT nextval('"Tour_TourID_seq"'::regclass),
    "TourName" text COLLATE pg_catalog."default",
    "TourDescription" text COLLATE pg_catalog."default",
    "RouteInfo" text COLLATE pg_catalog."default",
    "TourDistance" text COLLATE pg_catalog."default",
    CONSTRAINT "Tour_pkey" PRIMARY KEY ("TourID")
)

TABLESPACE pg_default;

ALTER TABLE public."Tour"
    OWNER to postgres;




INSERT TOUR :
CREATE PROCEDURE INSERT_TOUR(NUMERIC,CHARACTER VARYING,CHARACTER VARYING,CHARACTER VARYING,CHARACTER VARYING)
LANGUAGE 'plpgsql'
AS $$

BEGIN

INSERT INTO public."Tour"("TourID", "TourName", "TourDescription", "RouteInfo", "TourDistance")VALUES ($1, $2, $3, $4, $5);
COMMIT;

END;
$$;
TEST:
CALL public.insert_tour(1232,'1','2','2','32')



DELETE TOUR:
create or replace procedure delete_tour(id int)
as
$$
    begin
        DELETE FROM public."Tour" WHERE "TourID"=id;
    end;
$$
language plpgsql;

DELETE test:
CALL public.delete_tour(1232)
