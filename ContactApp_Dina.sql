PGDMP  
    '            
    |         
   ContactApp    16.2    16.2     �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    33465 
   ContactApp    DATABASE     �   CREATE DATABASE "ContactApp" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Indonesian_Indonesia.1252';
    DROP DATABASE "ContactApp";
                postgres    false            �            1259    33467    admin    TABLE     �   CREATE TABLE public.admin (
    id integer NOT NULL,
    username character varying NOT NULL,
    password character varying NOT NULL,
    email character varying NOT NULL
);
    DROP TABLE public.admin;
       public         heap    postgres    false            �            1259    33466    admin_id_seq    SEQUENCE     �   ALTER TABLE public.admin ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.admin_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    216            �            1259    33475    register    TABLE     �   CREATE TABLE public.register (
    id integer NOT NULL,
    nama character varying NOT NULL,
    email character varying NOT NULL,
    "Nomor_HP" integer NOT NULL
);
    DROP TABLE public.register;
       public         heap    postgres    false            �            1259    33474    register_id_seq    SEQUENCE     �   ALTER TABLE public.register ALTER COLUMN id ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.register_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    218            �          0    33467    admin 
   TABLE DATA           >   COPY public.admin (id, username, password, email) FROM stdin;
    public          postgres    false    216          �          0    33475    register 
   TABLE DATA           ?   COPY public.register (id, nama, email, "Nomor_HP") FROM stdin;
    public          postgres    false    218   5       �           0    0    admin_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.admin_id_seq', 1, false);
          public          postgres    false    215            �           0    0    register_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.register_id_seq', 1, false);
          public          postgres    false    217            V           2606    33473    admin admin_pkey 
   CONSTRAINT     N   ALTER TABLE ONLY public.admin
    ADD CONSTRAINT admin_pkey PRIMARY KEY (id);
 :   ALTER TABLE ONLY public.admin DROP CONSTRAINT admin_pkey;
       public            postgres    false    216            X           2606    33481    register register_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.register
    ADD CONSTRAINT register_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.register DROP CONSTRAINT register_pkey;
       public            postgres    false    218            �      x������ � �      �      x������ � �     